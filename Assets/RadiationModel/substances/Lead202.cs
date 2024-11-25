using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead202 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead202";
        public override double halfLife { get; } = 1656738613666.08d;
        public override double atomicWeight { get; } = 201.97215d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium202() }, { 0.20552d, new GammaParticle(12148.0, 0.10206) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury198() }, { 1.0d, new AlphaParticle(3610302.0900000003) } } },

        };
    }
}
    