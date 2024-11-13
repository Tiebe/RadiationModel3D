
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium243";
        public override double halfLife { get; } = 231943597200.0d;
        public override double atomicWeight { get; } = 243.06138d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Neptunium239() } },

            { 3.7e-11d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    