using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public sealed class BankAccountTests
    {
        [TestMethod]
        // Rút số tiền hợp lệ thì phải cập nhật số dư
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99; // Số dư ban đầu
            double debitAmount = 4.55; // Số tiền rút
            double expected = 7.44; // Số dư mong đợi
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance); // Tên khách hàng và số dư ban đầu

            // Act
            account.Debit(debitAmount); // Phương thức rút tiền

            // Assert
            double actual = account.Balance; // Số dư thực tế sau khi rút
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly"); // So sánh kq mong đợi với kq thực tế
            // (phần này để hiện lỗi nếu sai số quá mức cho phép)
        }

        [TestMethod]
        // Kiểm tra khi rút tiền âm chương trình có báo lỗi đúng hay không
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99; // Số dư ban đầu
            double debitAmount = -100.00; // Rút số tiền âm
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount)); // Gọi phương thức rút tiền
        }

        // Kiểm tra rút tiền vượt quá số dư
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return; // kết thúc test khi kiểm tra thành công.
            }

            Assert.Fail("The expected exception was not thrown."); // Báo test thất bại nếu không có ngoại lệ nào được ném ra.
        }
    }
}
