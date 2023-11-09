using System;
using System.Collections.Generic;
using System.IO;

namespace Tumakov9dz
{
    class Bank1
    {
        private static int numOfBankAccs;
        private int accNum;
        private decimal accBalance;
        private AccType bankAccType;

        public int AccNum
        {
            get
            {
                return accNum;
            }
        }

        public decimal AccBalance
        {
            get
            {
                return accBalance;
            }
        }

        public AccType BankAccType
        {
            get
            {
                return bankAccType;
            }
        }

        private void ChangeNumOfBankAccs()
        {
            numOfBankAccs++;
        }

        public bool MoreMoney(decimal moremoney)
        {
            if ((accBalance - moremoney > 0) && (moremoney > 0))
            {
                accBalance -= moremoney;
                return true;
            }

            return false;
        }

        public bool PutMoney(decimal pytmoney)
        {
            if (pytmoney > 0)
            {
                accBalance += pytmoney;
                return true;
            }

            return false;
        }

        public bool TransMoney(Bank1 dAcc, decimal dAmount)
        {
            if ((dAmount > 0) && (dAcc.AccBalance - dAmount > 0))
            {
                accBalance += dAmount;
                dAcc.accBalance -= dAmount;
                return true;
            }

            return false;
        }

        public Bank1(decimal accBalance)
        {
            this.accBalance = accBalance;
            bankAccType = AccType.Текущий;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }

        public Bank1(AccType bankAccType)
        {
            this.bankAccType = bankAccType;
            accBalance = 0;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }

        public Bank1(decimal accBalance, AccType bankAccType)
        {
            this.accBalance = accBalance;
            this.bankAccType = bankAccType;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }
    }

    class Bank2
    {
        private static int numOfBankAccs;
        private int accNum;
        private decimal accBalance;
        private Queue<BankTrans> transList = new Queue<BankTrans>();
        private AccType bankAccType;

        public int AccNum
        {
            get
            {
                return accNum;
            }
        }

        public decimal AccBalance
        {
            get
            {
                return accBalance;
            }
        }

        public AccType BankAccType
        {
            get
            {
                return bankAccType;
            }
        }

        public Queue<BankTrans> TransList
        {
            get
            {
                return transList;
            }
        }

        private void ChangeNumOfBankAccs()
        {
            numOfBankAccs++;
        }

        public bool MoreMoney(decimal withdrawalAmount)
        {
            if ((accBalance - withdrawalAmount > 0) && (withdrawalAmount > 0))
            {
                accBalance -= withdrawalAmount;
                BankTrans bankTrans = new BankTrans(-withdrawalAmount);
                transList.Enqueue(bankTrans);
                return true;
            }

            return false;
        }

        public bool PutMoney(decimal depositedAmoun)
        {
            if (depositedAmoun > 0)
            {
                accBalance += depositedAmoun;
                BankTrans bankTransaction = new BankTrans(depositedAmoun);
                transList.Enqueue(bankTransaction);
                return true;
            }

            return false;
        }

        public bool TransMoney(Bank2 withdrawalAccount, decimal withdrawalAmount)
        {
            if ((withdrawalAmount > 0) && (withdrawalAccount.AccBalance - withdrawalAmount > 0))
            {
                accBalance += withdrawalAmount;
                withdrawalAccount.accBalance -= withdrawalAmount;
                BankTrans bankTransaction = new BankTrans(-withdrawalAmount);
                transList.Enqueue(bankTransaction);
                return true;
            }

            return false;
        }

        public Bank2(decimal accBalance)
        {
            this.accBalance = accBalance;
            bankAccType = AccType.Текущий;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }

        public Bank2(AccType bankAccType)
        {
            this.bankAccType = bankAccType;
            accBalance = 0;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }

        public Bank2(decimal accBalance, AccType bankAccType)
        {
            this.accBalance = accBalance;
            this.bankAccType = bankAccType;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }
    }

    class Bank3
    {
        private static int numOfBankAccs;
        private int accNum;
        private decimal accBalance;
        private Queue<BankTrans> transactionList = new Queue<BankTrans>();
        private AccType bankAccType;

        public int AccNum
        {
            get
            {
                return accNum;
            }
        }

        public decimal AccBalance
        {
            get
            {
                return accBalance;
            }
        }

        public AccType BankAccType
        {
            get
            {
                return bankAccType;
            }
        }

        private void ChangeNumOfBankAccs()
        {
            numOfBankAccs++;
        }

        public bool MoreMoney(decimal withdrawalAmount)
        {
            if ((accBalance - withdrawalAmount > 0) && (withdrawalAmount > 0))
            {
                accBalance -= withdrawalAmount;
                BankTrans bankTransaction = new BankTrans(-withdrawalAmount);
                transactionList.Enqueue(bankTransaction);
                return true;
            }

            return false;
        }

        public bool PutMoney(decimal depositedAmoun)
        {
            if (depositedAmoun > 0)
            {
                accBalance += depositedAmoun;
                BankTrans bankTransaction = new BankTrans(depositedAmoun);
                transactionList.Enqueue(bankTransaction);
                return true;
            }

            return false;
        }

        public bool TransMoney(Bank3 withdrawalAccount, decimal withdrawalAmount)
        {
            if ((withdrawalAmount > 0) && (withdrawalAccount.AccBalance - withdrawalAmount > 0))
            {
                accBalance += withdrawalAmount;
                withdrawalAccount.accBalance -= withdrawalAmount;
                BankTrans bankTrans = new BankTrans(-withdrawalAmount);
                transactionList.Enqueue(bankTrans);
                return true;
            }

            return false;
        }

        public void Dispose(Bank3 bankAccount)
        {
            int count = transactionList.Count;

            for (int i = 0; i < count; i++)
            {
                BankTrans trans = transactionList.Dequeue();

                if (trans.AmountChange < 0)
                {
                    File.AppendAllText("check", $"Снятие {trans.TransDate}, {trans.AmountChange} рублей".ToString() + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText("check", $"Пополнение {trans.TransDate}, {trans.AmountChange} рублей".ToString() + Environment.NewLine);
                }
            }

            GC.SuppressFinalize(bankAccount);
        }

        public Bank3(decimal accBalance)
        {
            this.accBalance = accBalance;
            bankAccType = AccType.Текущий;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }

        public Bank3(AccType bankAccType)
        {
            this.bankAccType = bankAccType;
            accBalance = 0;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }

        public Bank3(decimal accBalance, AccType bankAccType)
        {
            this.accBalance = accBalance;
            this.bankAccType = bankAccType;
            accNum = numOfBankAccs;
            ChangeNumOfBankAccs();
        }
    }

    class BankTrans
    {
        private DateTime transDate;
        private decimal amountChange;

        public DateTime TransDate
        {
            get
            {
                return transDate;
            }
        }

        public decimal AmountChange
        {
            get
            {
                return amountChange;
            }
        }

        public BankTrans(decimal amountChange)
        {
            this.amountChange = amountChange;
            transDate = DateTime.Now;
        }
    }

    class Song
    {
        private string songName;
        private string songAuthor;
        private Song previousSong;

        public string SongName
        {
            get
            {
                return songName;
            }
        }

        public string SongAuthor
        {
            get
            {
                return songAuthor;
            }
        }

        public Song PreviousSong
        {
            get
            {
                return previousSong;
            }
        }

        public string Title
        {
            get
            {
                return songName + " " + songAuthor;
            }
        }

        public override bool Equals(object transmittedSong)
        {
            Song song = transmittedSong as Song;

            if ((song != null) && (song.SongName == songName) && (song.SongAuthor == songAuthor))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Song(string songName, string songAuthor, Song previousSong)
        {
            this.songName = songName;
            this.songAuthor = songAuthor;
            this.previousSong = previousSong;
        }

        public Song(string songName, string songAuthor)
        {
            this.songName = songName;
            this.songAuthor = songAuthor;
            previousSong = null;
        }

        public Song()
        {
            songName = "Пусто";
            songAuthor = "Пусто";
            previousSong = null;
        }
    }
}