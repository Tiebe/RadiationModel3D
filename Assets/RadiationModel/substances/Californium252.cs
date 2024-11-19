using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium252";
        public override double halfLife { get; } = 83468138.04d;
        public override double atomicWeight { get; } = 252.08163d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9689719999999999d, new List<RadioactiveSubstance> { new AlphaParticle(7238902.09), new Curium248() } },
            { 0.031027999999999997d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    