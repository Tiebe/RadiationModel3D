
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium170";
        public override double halfLife { get; } = 173836.8d;
        public override double atomicWeight { get; } = 169.93848d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium170() } },

        };
    }
}
    
    