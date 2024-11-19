using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium92m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium92m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 91.92328d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00044, 2834200.0), new Ruthenium92() } },

        };
    }
}
    
    