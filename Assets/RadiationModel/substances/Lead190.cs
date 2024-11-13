
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead190 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead190";
        public override double halfLife { get; } = 71.0d;
        public override double atomicWeight { get; } = 189.97808d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.996d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium190() } },

            { 0.004d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mercury186() } },

        };
    }
}
    
    