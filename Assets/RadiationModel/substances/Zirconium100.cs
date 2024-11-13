
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium100";
        public override double halfLife { get; } = 7.1d;
        public override double atomicWeight { get; } = 99.91801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium100() } },

        };
    }
}
    
    