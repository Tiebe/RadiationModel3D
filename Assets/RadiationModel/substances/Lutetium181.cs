
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium181";
        public override double halfLife { get; } = 210.0d;
        public override double atomicWeight { get; } = 180.95191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium181() } },

        };
    }
}
    
    