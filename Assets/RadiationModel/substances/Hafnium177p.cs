
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium177p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium177p";
        public override double halfLife { get; } = 3084.0d;
        public override double atomicWeight { get; } = 176.94617d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Hafnium177() } },

        };
    }
}
    
    