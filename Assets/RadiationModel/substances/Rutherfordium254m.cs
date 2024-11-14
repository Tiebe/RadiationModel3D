using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium254m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium254m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 254.10145d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00095), new Rutherfordium254() } },
            { 0.1d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    