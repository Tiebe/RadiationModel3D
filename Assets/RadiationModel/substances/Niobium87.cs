
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium87";
        public override double halfLife { get; } = 222.0d;
        public override double atomicWeight { get; } = 86.92069d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium87() } },

        };
    }
}
    
    