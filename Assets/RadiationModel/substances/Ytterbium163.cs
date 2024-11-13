
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium163";
        public override double halfLife { get; } = 663.0d;
        public override double atomicWeight { get; } = 162.93635d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thulium163() } },

        };
    }
}
    
    