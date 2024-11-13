
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium176";
        public override double halfLife { get; } = 111.0d;
        public override double atomicWeight { get; } = 175.947d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium176() } },

        };
    }
}
    
    