﻿using Prism.Commands;
using Prism.Mvvm;
using System;

namespace PrismObservesSample {
    class MainWindowViewModel : BindableBase {

        private string _input1 = "";

        public string Input1 {

            get => _input1;

            set => SetProperty(ref _input1, value);

        }

        private string _input2 = "";

        public string Input2 {

            get => _input2;

            set => SetProperty(ref _input2, value);

        }

        private string _result = "";

        public string Result {

            get => _result;

            set => SetProperty(ref _result, value);

        }

        // コンストラクタ

        public MainWindowViewModel() {

            SumCommand = new DelegateCommand(ExcuteSum, canExcuteSum);

        }

        public DelegateCommand SumCommand { get; }

        // 足し算の処理

        private void ExcuteSum() {

            Result =  ;

        }

        //足し算処理を実行できるか否かのチェック

        private bool canExcuteSum() {

        }

    }

}

