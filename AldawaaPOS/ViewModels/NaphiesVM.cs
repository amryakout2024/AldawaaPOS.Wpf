using AldawaaPOS.Helpers;
using AldawaaPOS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace AldawaaPOS.ViewModels
{
     class NaphiesVM : ViewModelBase, INotifyDataErrorInfo
    {
        private ObservableCollection<Approval> approvals;
        public ObservableCollection<Approval> Approvals
        {
            get { return approvals; }
            set { approvals = value;OnPropertyChanged();}
        }


        private SetError _setError;
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
        public bool HasErrors => _setError.HasErrors;

        public NaphiesVM()
        {
            Approvals = new ObservableCollection<Approval>()
            {
                new Approval(){ Id=1,Type="Direct",PatientName="John Doe",PatientId="2525268569",Bayer="Medgulf",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Approved",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=2,Type="Authorization",PatientName="Jane Smith",PatientId="2535854568",Bayer="Bupa",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Pending",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=3,Type="Authorization",PatientName="Alice Johnson",PatientId="2564568524",Bayer="Tawynia",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=4,Type="Direct",PatientName="Amr yakout",PatientId="2520268569",Bayer="Malath",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Approved",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=5,Type="Authorization",PatientName="mohamad amer",PatientId="2545854568",Bayer="Saico",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=6,Type="Authorization",PatientName="Saad qahtani",PatientId="1064568524",Bayer="Tawynia",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=7,Type="Direct",PatientName="Nomaam sayed",PatientId="2525268569",Bayer="Medgulf",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Approved",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=8,Type="Authorization",PatientName="ahmad sherif",PatientId="2135854568",Bayer="Al-Etihad",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Pending",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=9,Type="Authorization",PatientName="Walid shahrani",PatientId="1064568524",Bayer="TCS-TCA",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=10,Type="Direct",PatientName="Fahda mohamad",PatientId="1125268529",Bayer="Globmed-Walaa",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Approved",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=11,Type="Authorization",PatientName="Gedad samir",PatientId="2535854565",Bayer="Bupa",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=12,Type="Authorization",PatientName="Johnson Felep",PatientId="2564565524",Bayer="Saico",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=13,Type="Direct",PatientName="John Doe",PatientId="2525268569",Bayer="Medgulf",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Approved",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=14,Type="Authorization",PatientName="Jane Smith",PatientId="2535854568",Bayer="Bupa",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=15,Type="Authorization",PatientName="Alice Johnson",PatientId="2564568524",Bayer="Tawynia",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Approved",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=16,Type="Direct",PatientName="Amr yakout",PatientId="2520268569",Bayer="Malath",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Approved",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=17,Type="Authorization",PatientName="mohamad amer",PatientId="2545854568",Bayer="Saico",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=18,Type="Authorization",PatientName="Saad qahtani",PatientId="1064568524",Bayer="Tawynia",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=19,Type="Direct",PatientName="Nomaam sayed",PatientId="2525268569",Bayer="Medgulf",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Approved",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=20,Type="Authorization",PatientName="ahmad sherif",PatientId="2135854568",Bayer="Al-Etihad",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Pending",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=21,Type="Authorization",PatientName="Walid shahrani",PatientId="1064568524",Bayer="TCS-TCA",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=22,Type="Direct",PatientName="Fahda mohamad",PatientId="1125268529",Bayer="Globmed-Walaa",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Approved",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=23,Type="Authorization",PatientName="Gedad samir",PatientId="2535854565",Bayer="Bupa",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=24,Type="Authorization",PatientName="Johnson Felep",PatientId="2564565524",Bayer="Saico",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=25,Type="Direct",PatientName="John Doe",PatientId="2525268569",Bayer="Medgulf",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Pending",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=26,Type="Authorization",PatientName="Jane Smith",PatientId="2535854568",Bayer="Bupa",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=27,Type="Authorization",PatientName="Alice Johnson",PatientId="2564568524",Bayer="Tawynia",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=28,Type="Direct",PatientName="Amr yakout",PatientId="2520268569",Bayer="Malath",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Pending",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=29,Type="Authorization",PatientName="mohamad amer",PatientId="2545854568",Bayer="Saico",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=30,Type="Authorization",PatientName="Saad qahtani",PatientId="1064568524",Bayer="Tawynia",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=31,Type="Direct",PatientName="Nomaam sayed",PatientId="2525268569",Bayer="Medgulf",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Pending",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=32,Type="Authorization",PatientName="ahmad sherif",PatientId="2135854568",Bayer="Al-Etihad",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=33,Type="Authorization",PatientName="Walid shahrani",PatientId="1064568524",Bayer="TCS-TCA",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Rejected",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                new Approval(){ Id=34,Type="Direct",PatientName="Fahda mohamad",PatientId="1125268529",Bayer="Globmed-Walaa",RequestTime=DateTime.Now.AddHours(-2),ResponseTime=DateTime.Now.AddHours(-1),Status="Pending",IsInvoiced=false,HasError=false,HasComment=true,IsDispensed=false,IsCancelled=false },
                new Approval(){ Id=35,Type="Authorization",PatientName="Gedad samir",PatientId="2535854565",Bayer="Bupa",RequestTime=DateTime.Now.AddHours(-3),ResponseTime=DateTime.Now.AddHours(-2),Status="Approved",IsInvoiced=true,HasError=false,HasComment=false,IsDispensed=true,IsCancelled=false },
                new Approval(){ Id=36,Type="Authorization",PatientName="Johnson Felep",PatientId="2564565524",Bayer="Saico",RequestTime=DateTime.Now.AddHours(-4),ResponseTime=DateTime.Now.AddHours(-3),Status="Approved",IsInvoiced=false,HasError=true,HasComment=true,IsDispensed=false,IsCancelled=true },
                
                
            };
            _setError = new SetError();
            _setError.ErrorsChanged += _setError_ErrorsChanged;
        }

        private void _setError_ErrorsChanged(object sender, DataErrorsChangedEventArgs e)
        {
            ErrorsChanged?.Invoke(this, e);
        }

        public IEnumerable GetErrors(string propertyName)
        {
            return _setError.GetErrors(propertyName);
        }
    }
}
