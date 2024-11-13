
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium82";
        public override double halfLife { get; } = 0.051d;
        public override double atomicWeight { get; } = 81.94438d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium82() } },

        };
    }
}
    
    