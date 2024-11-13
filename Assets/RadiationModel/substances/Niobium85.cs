
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium85";
        public override double halfLife { get; } = 20.5d;
        public override double atomicWeight { get; } = 84.92885d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium85() } },

        };
    }
}
    
    