
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium107";
        public override double halfLife { get; } = 225.0d;
        public override double atomicWeight { get; } = 106.90997d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium107() } },

        };
    }
}
    
    