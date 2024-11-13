
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium160m";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 159.94603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium160() } },

        };
    }
}
    
    