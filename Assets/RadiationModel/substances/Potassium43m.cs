using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium43m : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium43m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 42.96153d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((738300.0, 0.00168)), new Potassium43() } },

        };
    }
}
    
    