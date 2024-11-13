
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium86";
        public override double halfLife { get; } = 88.0d;
        public override double atomicWeight { get; } = 85.92578d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium86() } },

        };
    }
}
    
    