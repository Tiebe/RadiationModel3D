using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum42 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum42";
        public override double halfLife { get; } = 0.003d;
        public override double atomicWeight { get; } = 42.04508d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    