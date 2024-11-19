using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium254n : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium254n";
        public override double halfLife { get; } = 0.00025d;
        public override double atomicWeight { get; } = 254.1022d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00062, 2000000.0), new Rutherfordium254() } },
            { 0.4d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    