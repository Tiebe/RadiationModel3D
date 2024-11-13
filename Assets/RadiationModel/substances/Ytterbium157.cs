
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium157";
        public override double halfLife { get; } = 38.6d;
        public override double atomicWeight { get; } = 156.94265d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thulium157() } },

        };
    }
}
    
    