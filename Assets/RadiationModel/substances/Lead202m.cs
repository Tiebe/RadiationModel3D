
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

            { 0.905d, new List<RadioactiveSubstance> { new GammaParticle(), new Lead202() } },

            { 0.095d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium202() } },

        };
    }
}
    
    