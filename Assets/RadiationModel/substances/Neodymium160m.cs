
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium160m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 159.95104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Neodymium160() } },

        };
    }
}
    
    