﻿using ET_6_LuckyTicket.Logics;
using ET_6_LuckyTicket.Logics.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests
{
    public class LuckyTicketCounterTests
    {
        [Fact]
        public void GetCountLuckyTickets_ModeMoskowStandardValues_55251()
        {
            //arrange          
            string mode = "Moskow";
            int expected = 55251;

            var factory = new LuckyTicketDeterminatorFactory();
            var counter = new LuckyTicketCounter(factory);

            //act
            var actual = counter.GetCountLuckyTickets(mode);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetCountLuckyTickets_ModePiterStandardValues_55251()
        {
            //arrange          
            string mode = "Piter";
            int expected = 55251;

            var factory = new LuckyTicketDeterminatorFactory();
            var counter = new LuckyTicketCounter(factory);

            //act
            var actual = counter.GetCountLuckyTickets(mode);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
