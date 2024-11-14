using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium261p : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium261p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 261.10902d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    