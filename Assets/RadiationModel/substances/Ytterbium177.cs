
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium177";
        public override double halfLife { get; } = 6879.6d;
        public override double atomicWeight { get; } = 176.94526d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium177() } },

        };
    }
}
    
    