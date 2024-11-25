using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum186m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum186m";
        public override double halfLife { get; } = 92.4d;
        public override double atomicWeight { get; } = 185.95892d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum186() } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    