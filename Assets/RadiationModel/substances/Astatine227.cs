using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine227 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine227";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 227.04018d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    