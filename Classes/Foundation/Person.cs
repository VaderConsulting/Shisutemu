using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person : ClassBase
    {
        #region Constants

        public const string KANJITYPENAME = "人";
        public const string JAPANESETYPENAME = "Hito";
        public const string ENGLISHTYPENAME = "Person";

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

        private Address _Address = new Address();
        private Player _Player = null;
        private EmailAddress _EmailAddress = new EmailAddress();
        private Guid _Identifier = Guid.Empty;
        private Name _Name = null;
        private ObservableCollection<Person> _Parents = null;
        private PhoneNumber _PhoneNumber = null;
        private Enums.Sex _Sex = Classes.Enums.Sex.Unknown;
        private ObservableCollection<Person> _Siblings = new ObservableCollection<Person>();
        private bool _SpecialNeeds = false;

        #endregion

        #region Properties

        public Address Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }

        public ObservableCollection<Person> Parents
        {
            get
            {
                return _Parents;
            }
            set
            {
                _Parents = value;
            }
        }

        public ObservableCollection<Person> Siblings
        {
            get
            {
                return _Siblings;
            }
            set
            {
                _Siblings = value;
            }
        }

        public Name Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public Enums.Sex Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;
            }
        }

        public Guid Identifier
        {
            get
            {
                return _Identifier;
            }
            set
            {
                _Identifier = value;
            }
        }

        public PhoneNumber PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
            }
        }

        public Player Player
        {
            get
            {
                return _Player;
            }
            set
            {
                _Player = value;
            }
        }

        public bool SpecialNeeds
        {
            get
            {
                return _SpecialNeeds;
            }
            set
            {
                _SpecialNeeds = value;
            }
        }

        #endregion

        #region Constructors and Destructor

        public Person(Name Name, Enums.Sex Sex)
        {
            base.KanjiTypeName = KANJITYPENAME;
            base.JapaneseTypeName = JAPANESETYPENAME;
            base.EnglishTypeName = ENGLISHTYPENAME;
            base.ObjectName = Name.ToString();

            _Name = Name;
            _Sex = Sex;
        }

        #endregion

        #region Event Handlers

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return _Name.First + " " + _Name.Last;
        }

        #endregion

    }
}
