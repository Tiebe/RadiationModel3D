using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium238m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium238m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 238.05353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9740000000000001d, new List<RadioactiveSubstance> { new GammaParticle(0.00048), new Uranium238() } },
            { 0.026000000000000002d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    