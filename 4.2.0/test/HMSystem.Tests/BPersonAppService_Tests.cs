using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HMSystem.Tests
{
    public class BPersonAppService_Tests: HMSystemTestBase
    {
        private readonly IBPersons _BPersons;
        public BPersonAppService_Tests()
        {
            _BPersons = Resolve<IBPersons>();
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Tasks()
        {
            var output = await _BPersons.GetAll(new GetAllSPBI());

            output.Items.Count.ShouldBe(2);
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_Filtered_Person()
        {
            var output = await _BPersons.GetAll(new GetAllSPBI { gender = ServicePersonalBase.Gender.Man });

            output.Items.ShouldAllBe(t => t.ServicePersonalGender == ServicePersonalBase.Gender.Man);
        }
    }
}
