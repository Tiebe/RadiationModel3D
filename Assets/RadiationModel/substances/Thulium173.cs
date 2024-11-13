
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium173";
        public override double halfLife { get; } = 29664.0d;
        public override double atomicWeight { get; } = 172.93961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium173() } },

        };
    }
}
    
    