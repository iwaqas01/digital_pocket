using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Schedule;
using DevComponents.Schedule.Model;
using DigitalPocket.DataBaseFiles;
using DigitalPocket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DigitalPocket
{
    public partial class Form1 : Form
    {
        DigitalPocketContext _context = null;
        int id;
        string username;

        public Form1(int _id,string _username)
        {
            id = _id;
            username = _username;
            this.Text = "Welcome"+username;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            calendarView1.CalendarModel = new CalendarModel();
            LoadAppointments();

           

        }


        #region LoadAppointments
        private void LoadAppointments()
        {

            using (_context = new DigitalPocketContext())
            {
               var obj= _context.Transaction.Where(x=>x.UserId==id).ToList().Where(x => x.DateTime.Value.Month == DateTime.Now.Month && x.DateTime.Value.Year == DateTime.Now.Year);
                foreach(var items in obj)
                {
                    if(items.Type== "Expense")
                    {
                        AddAppointment(items.TransactionName + " Ammount:" + items.Ammount,
             items.DateTime.Value.Date, items.DateTime.Value.Date,
             Appointment.CategoryRed,"", items.TransactionName + " Ammount:" + items.Ammount,items.TransactionName + " Ammount:" + items.Ammount);

                    }
                    if (items.Type == "Transfer")
                    {
                        AddAppointment(items.TransactionName + " Ammount:" + items.Ammount,
             items.DateTime.Value.Date, items.DateTime.Value.Date,
             Appointment.CategoryYellow,"", items.TransactionName + " Ammount:" + items.Ammount, items.TransactionName + " Ammount:" + items.Ammount);

                    }
                    if (items.Type == "Income")
                    {
                        AddAppointment(items.TransactionName + " Ammount:" + items.Ammount,
             items.DateTime.Value.Date, items.DateTime.Value.Date,
             Appointment.CategoryBlue, "",items.TransactionName + " Ammount:" + items.Ammount, items.TransactionName + " Ammount:" + items.Ammount);

                    }
                }
            }
        }


        #endregion


        #region AddAppointment

        /// <summary>
        /// Adds the specified appointment to the model
        /// </summary>
        /// <param name="s">Appointment subject</param>
        /// <param name="startTime">Appointment start time</param>
        /// <param name="endTime">Appointment end time</param>
        /// <param name="color">Appointment color</param>
        /// <param name="marker">Appointment marker</param>
        private Appointment AddAppointment(string s,
            DateTime startTime, DateTime endTime, string color, string marker,string Description,string Tooltip)
        {
            Appointment appointment = new Appointment();

            appointment.StartTime = startTime;
            appointment.EndTime = endTime;

            appointment.Subject = s;
            appointment.Description = Description;
            appointment.CategoryColor = color;
            appointment.TimeMarkedAs = marker;
            appointment.Tooltip = Tooltip;
            calendarView1.CalendarModel.Appointments.Add(appointment);
            return (appointment);
        }

        #endregion
        //when a clender cell is click it will automaticaly call
        private void calendarView1_MouseUp(object sender, MouseEventArgs e)
        {
            DateTime startDate1 = calendarView1.DateSelectionStart.GetValueOrDefault();
            if (e.Button==MouseButtons.Left)
            {
                getexpenseandincome(startDate1);
            }
            if (e.Button == MouseButtons.Right)
            {
                // Main Calendar View hit
                if (sender is BaseView)
                    BaseViewMouseUp(sender, e);

                // AppointmentView hit

                else if (sender is AppointmentView)
                    AppointmentViewMouseUp(sender);




            }

        }

        private void BaseViewMouseUp(object sender, MouseEventArgs e)
        {
            BaseView view = sender as BaseView;
            eViewArea area = view.GetViewAreaFromPoint(e.Location);

            if (area == eViewArea.InContent)
                InContentMouseUp(view, e);
            /*
            else if (area == eViewArea.InDayOfWeekHeader)
                InHeaderMouseUp(view);

            else if (area == eViewArea.InSideBarPanel)
                InSideBarMouseUp(view);

            else if (area == eViewArea.InCondensedView)
                InCondensedViewMouseUp();
                */
        }

        private void InContentMouseUp(BaseView view, MouseEventArgs e)
        {
            // Get the DateSelection start and end
            // from the current mouse location

            DateTime startDate, endDate;

            if (calendarView1.GetDateSelectionFromPoint(
                e.Location, out startDate, out endDate) == true)
            {
                //yaha pa dateclick ka record show karwa dena




                // If this date already falls outside the currently
                // selected range (DateSelectionStart and DateSelectionEnd)
                // then select the new range

                if (IsDateSelected(startDate, endDate) == false)
                {
                    calendarView1.DateSelectionStart = startDate;
                    calendarView1.DateSelectionEnd = endDate;
                }
            }

            // Remove any previously added view specific items

            for (int i = InContentContextMenu.SubItems.Count - 1; i > 3; i--)
                InContentContextMenu.SubItems.RemoveAt(i);

            // If this is a TimeLine view, then add a couple
            // of extra items

            if (view is TimeLineView)
            {
                ButtonItem bi = new ButtonItem();

                // Page Navigator

                bi.Text = (calendarView1.TimeLineShowPageNavigation == true)
                    ? "Hide Page Navigator" : "Show Page Navigator";

                bi.BeginGroup = true;

                bi.Click += BiPageNavigatorClick;

                InContentContextMenu.SubItems.Add(bi);

                // Condensed Visibility

                if (calendarView1.TimeLineCondensedViewVisibility ==
                    eCondensedViewVisibility.Hidden)
                {
                    bi = new ButtonItem("", "Show Condensed View");
                    bi.Click += BiCondensedClick;

                    InContentContextMenu.SubItems.Add(bi);
                }
            }

            ShowContextMenu(InContentContextMenu);
        }

        private bool IsDateSelected(DateTime startDate, DateTime endDate)
        {
            if (calendarView1.DateSelectionStart.HasValue && calendarView1.DateSelectionEnd.HasValue)
            {
                if (calendarView1.DateSelectionStart.Value <= startDate &&
                    calendarView1.DateSelectionEnd.Value >= endDate)
                    return (true);
            }

            return (false);
        }

        private void BiPageNavigatorClick(object sender, EventArgs e)
        {
            calendarView1.TimeLineShowPageNavigation =
                (calendarView1.TimeLineShowPageNavigation == false);
        }
        private void BiCondensedClick(object sender, EventArgs e)
        {
            calendarView1.TimeLineCondensedViewVisibility =
                eCondensedViewVisibility.AllResources;
        }
        private void ShowContextMenu(ButtonItem cm)
        {
            cm.Popup(MousePosition);
        }

        private void InContentAddAppContextItem_Click(object sender, EventArgs e)
        {
            //it will get the date of calender
            DateTime startDate = calendarView1.DateSelectionStart.GetValueOrDefault();
            DateTime endDate = calendarView1.DateSelectionEnd.GetValueOrDefault();
            using (AddTransaction addTransaction = new AddTransaction(startDate,id))
            {
                addTransaction.ShowDialog();
                
                if(TransacModel.Allow==true)
                {
                    if(TransacModel.Type== "Expense")
                    {
                        AddAppointment(TransacModel.TransactionName + " Ammount:" + TransacModel.Ammount,
              startDate, endDate,
              Appointment.CategoryRed, Appointment.TimerMarkerDefault, TransacModel.TransactionName+ " Ammount:"+ TransacModel.Ammount, TransacModel.TransactionName + " Ammount:" + TransacModel.Ammount);

                        TransacModel.Allow = false;
                        getexpenseandincome(startDate);

                    }
                    else if(TransacModel.Type == "Transfer")
                    {
                        AddAppointment(TransacModel.TransactionName+ " Ammount:"+ TransacModel.Ammount,
             startDate, endDate,
             Appointment.CategoryYellow, Appointment.TimerMarkerDefault, TransacModel.TransactionName + " Ammount:" + TransacModel.Ammount, TransacModel.TransactionName + " Ammount:" + TransacModel.Ammount);

                        TransacModel.Allow = false;
                        getexpenseandincome(startDate);
                    }
                    else
                    {
                        AddNewAppointment(startDate, endDate);
                        TransacModel.Allow = false;
                        getexpenseandincome(startDate);


                    }
                }
               
            }
        }

        private Appointment AddNewAppointment(DateTime startDate, DateTime endDate)
        {
            // Create new appointment and add it to the model
            // Appointment will show up in the view automatically

            Appointment appointment = new Appointment();

            appointment.StartTime = startDate;
            appointment.EndTime = endDate;

            appointment.Subject = TransacModel.TransactionName +
                appointment.CategoryColor + " Ammount :"+TransacModel.Ammount.ToString();

            appointment.Description = TransacModel.TransactionName;
            appointment.Tooltip = "Ammount:"+TransacModel.Ammount.ToString()+ " Category:"+TransacModel.Category;

            // Add appointment to the model

            calendarView1.CalendarModel.Appointments.Add(appointment);

            return (appointment);
        }

        private void AppointmentViewMouseUp(object sender)
        {
            AppointmentView view = sender as AppointmentView;

            // Select the appointment
            view.IsSelected = true;

            // Let the user delete the appointment
           


            
            //ShowContextMenu(AppointmentContextMenu);
        }

        public void getexpenseandincome(DateTime startDate1)
        {
            using (_context = new DigitalPocketContext())
            {
                lbldate.Text = startDate1.Date.ToString("dd-MMM-yyyy");
                var obj = _context.Transaction.ToList();
                var income = obj.Where(x=>x.UserId==id).Where(x => x.DateTime.Value.Date.Day == startDate1.Date.Day).Where(x => x.Type == "Income").Sum(x => x.Ammount);
                var Expense = obj.Where(x => x.UserId == id).Where(x => x.DateTime.Value.Date.Day == startDate1.Date.Day).Where(x => x.Type == "Expense").Sum(x => x.Ammount);
                var Transfer = obj.Where(x => x.UserId == id).Where(x => x.DateTime.Value.Date.Day == startDate1.Date.Day).Where(x => x.Type == "Transfer").Sum(x => x.Ammount);
                var MonthlyCredit = obj.Where(x => x.UserId == id).Where(x => x.DateTime.Value.Month == startDate1.Date.Month && x.DateTime.Value.Year == startDate1.Date.Year).Where(x => x.Type == "Income").Sum(x => x.Ammount);
                var MonthlyDebit = obj.Where(x => x.UserId == id).Where(x => x.DateTime.Value.Month == startDate1.Date.Month && x.DateTime.Value.Year == startDate1.Date.Year).Where(x => x.Type == "Expense").Sum(x => x.Ammount);
                var MonthlyTransefer = obj.Where(x => x.UserId == id).Where(x => x.DateTime.Value.Month == startDate1.Date.Month && x.DateTime.Value.Year == startDate1.Date.Year).Where(x => x.Type == "Transfer").Sum(x => x.Ammount);
                var monthlyincome = _context.UWallet.Where(x => x.UserId == id).ToList().Where(x => x.Date.Value.Month == DateTime.Now.Month).Sum(x=>x.Ammount);
                if(monthlyincome<=0)
                {
                    lblincme.Text = monthlyincome.Value.ToString();
                    lblincme.ForeColor = Color.Red;
                }
                else
                {
                    lblincme.Text = monthlyincome.ToString();
                    lblincme.ForeColor = Color.Black;


                }
                lblcredit.Text = MonthlyCredit.Value.ToString();
                lblddebit.Text = MonthlyDebit.Value.ToString();
                lblmonthlytrans.Text = MonthlyTransefer.Value.ToString();
                lblincome.Text = income.Value.ToString();
                lblexpense.Text = Expense.Value.ToString();
                lblTransfer.Text = Transfer.Value.ToString();

            }
        }

    }
}

