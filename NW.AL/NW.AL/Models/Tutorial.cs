using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;
using NW.AL.ViewModel;

namespace NW.AL.Models
{
    [Table("Tutorial")]

    public class Tutorial : BaseViewModel
    {
        private bool _skipTutorialFlag;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("SkipTutorialFlag")]
        public bool SkipTutorialFlag
        {
            get => _skipTutorialFlag;
            set => SetProperty(ref _skipTutorialFlag, value);
        }
    }
}
