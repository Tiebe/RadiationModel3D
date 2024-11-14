using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium258n : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium258n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 258.10504d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    