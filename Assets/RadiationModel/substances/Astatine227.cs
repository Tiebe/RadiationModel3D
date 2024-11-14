using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine227 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine227";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 227.04018d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    