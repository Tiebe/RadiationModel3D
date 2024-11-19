using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium254n : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium254n";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 254.09441d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00039, 3217000.0), new Nobelium254() } },
            { 0.00012d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    