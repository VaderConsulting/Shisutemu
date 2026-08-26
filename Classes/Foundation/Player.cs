using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Player : ClassBase
    {
        #region Constants

        public const string KANJITYPENAME = "柔道";
        public const string JAPANESETYPENAME = "Jūdōka";
        public const string ENGLISHTYPENAME = "Player";

        #endregion

        #region Delegates

        #endregion

        #region Events

        #endregion

        #region Enums

        #endregion

        #region DLL Imports

        #endregion

        #region Fields

        private AgeCategory _AgeCategory = null;                                                      // Calculated
        private Club _Club = null;
        private DateTime _DateOfBirth = DateTime.MinValue;
        private Guid _Identifier = Guid.Empty;
        private Person _Person = null;
        private List<WeightCategory> _EligibleWeightCategories = new List<WeightCategory>();          // Calculated
        private WeightCategory _PrimaryWeightCategory = null;                                         // Calculated
        private Rank _Rank = null;
        private Weight _Weight = new Weight(0);
        private List<string> _SystemComments = new List<string>();
        private bool _Flag;
        //private WeightCategory _AddFivePercentWeightCategory = null;
        //private WeightCategory _RemoveFivePercentWeightCategory = null;
        //private List<WeightCategory> _AddFivePercentEligibleWeightCategories = new List<WeightCategory>();
        //private List<WeightCategory> _RemoveFivePercentEligibleWeightCategories = new List<WeightCategory>();

        #endregion

        #region Properties

        public Club Club
        {
            get
            {
                return _Club;
            }
            set
            {
                _Club = value;
            }
        }

        public Rank Rank
        {
            get
            {
                return _Rank;
            }
            set
            {
                _Rank = value;
            }
        }

        public Weight Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                _Weight = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                _DateOfBirth = value;
            }
        }

        public WeightCategory PrimaryWeightCategory
        {
            get
            {
                return _PrimaryWeightCategory;
            }
            set
            {
                _PrimaryWeightCategory = value;
            }
        }

        public List<WeightCategory> EligibleWeightCategories
        {
            get
            {
                return _EligibleWeightCategories;
            }
            set
            {
                _EligibleWeightCategories = value;
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - _DateOfBirth.Year;
            }
        }

        public int AgeThisYear
        {
            get
            {
                DateTime Date = new DateTime(DateTime.Now.Year, 12, 31);

                return AgeAtDate(Date);
            }
        }

        //public WeightCategory AddFivePercentWeightCategory
        //{
        //    get
        //    {
        //        return _AddFivePercentWeightCategory;
        //    }
        //    set
        //    {
        //        _AddFivePercentWeightCategory = value;
        //    }
        //}

        //public WeightCategory RemoveFivePercentWeightCategory
        //{
        //    get
        //    {
        //        return _RemoveFivePercentWeightCategory;
        //    }
        //    set
        //    {
        //        _RemoveFivePercentWeightCategory = value;
        //    }
        //}

        //public List<WeightCategory> AddFivePercentEligibleWeightCategories
        //{
        //    get
        //    {
        //        return _AddFivePercentEligibleWeightCategories;
        //    }
        //    set
        //    {
        //        _AddFivePercentEligibleWeightCategories = value;
        //    }
        //}

        //public List<WeightCategory> RemoveFivePercentEligibleWeightCategories
        //{
        //    get
        //    {
        //        return _RemoveFivePercentEligibleWeightCategories;
        //    }
        //    set
        //    {
        //        _RemoveFivePercentEligibleWeightCategories = value;
        //    }
        //}

        public AgeCategory AgeCategory
        {
            get
            {
                return _AgeCategory;
            }
            set
            {
                _AgeCategory = value;
            }
        }

        public List<string> SystemComments
        {
            get
            {
                return _SystemComments;
            }
            set
            {
                _SystemComments = value;
            }
        }

        public bool Flag
        {
            get
            {
                return _Flag;
            }
            set
            {
                _Flag = value;
            }
        }

        #endregion

        #region Constructors and Destructor

        public Player(Person Person) : base()
        {
            base.KanjiTypeName = KANJITYPENAME;
            base.JapaneseTypeName = JAPANESETYPENAME;
            base.EnglishTypeName = ENGLISHTYPENAME;
            base.ObjectName = null;

            _Person = Person;
        }

        #endregion

        #region Event Handlers

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        public int AgeAtDate(DateTime Date)
        {
            int age = Date.Year - DateOfBirth.Year;

            if (Date < DateOfBirth.AddYears(age))
            {
                age--;
            }

            if (age < 0)
            {
                age = 0;
            }

            return age;
        }

        private void Load(string ConnectionString)
        {
            string Query = "SELECT Club";

            Utilities.Data.GetDataRowFromDataset(Utilities.Data.Execute(Query, ConnectionString), 0, 0);

        }

        private void Save(string ConnectionString)
        {
        }

        #endregion

    }
}
