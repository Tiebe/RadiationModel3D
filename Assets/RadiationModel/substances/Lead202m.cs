using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead202m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead202m";
        public override double halfLife { get; } = 12744.0d;
        public override double atomicWeight { get; } = 201.97448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.905d, new List<RadioactiveSubstance> { new GammaParticle(0.00057, 2170000.0), new Lead202() } },
            { 0.095d, new List<RadioactiveSubstance> { new BetaParticle(1, 2209400.0), new Thallium202() } },

        };
    }
}
    
    