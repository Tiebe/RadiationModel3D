
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium160";
        public override double halfLife { get; } = 36.1d;
        public override double atomicWeight { get; } = 159.94603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium160() } },

        };
    }
}
    
    