using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon127 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon127";
        public override double halfLife { get; } = 3139948.8d;
        public override double atomicWeight { get; } = 126.90518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Iodine127() } },

        };
    }
}
    
    