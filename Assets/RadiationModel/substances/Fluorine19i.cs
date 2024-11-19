using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine19i : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine19i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 19.0065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((7539645.1, 0.00016)), new Fluorine19() } },

        };
    }
}
    
    