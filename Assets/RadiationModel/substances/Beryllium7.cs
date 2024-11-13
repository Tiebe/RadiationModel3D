
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium7 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium7";
        public override double halfLife { get; } = 4598208.0d;
        public override double atomicWeight { get; } = 7.01693d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Lithium7() } },

        };
    }
}
    
    