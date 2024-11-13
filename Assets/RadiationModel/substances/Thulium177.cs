
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium177";
        public override double halfLife { get; } = 95.0d;
        public override double atomicWeight { get; } = 176.94893d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium177() } },

        };
    }
}
    
    