
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177";
        public override double halfLife { get; } = 574067.52d;
        public override double atomicWeight { get; } = 176.94376d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium177() } },

        };
    }
}
    
    