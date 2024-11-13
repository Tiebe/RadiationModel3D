
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium109m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium109m";
        public override double halfLife { get; } = 80.4d;
        public override double atomicWeight { get; } = 108.90785d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Indium109() } },

        };
    }
}
    
    