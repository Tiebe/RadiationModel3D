using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium215";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 215.01172d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium211() }, { 1.0d, new AlphaParticle(8686002.09) }, { 0.0021060000000000002d, new GammaParticle(60900.0, 0.02036) }, { 0.1404d, new GammaParticle(133880.0, 0.00926) }, { 0.019656d, new GammaParticle(194490.0, 0.00637) }, { 0.0016848d, new GammaParticle(295100.0, 0.0042) }, { 0.1923811336878912d, new GammaParticle(14920.0, 0.0831) }, { 0.022787746474523227d, new GammaParticle(85432.0, 0.01451) }, { 0.037222715574196714d, new GammaParticle(88471.0, 0.01401) }, { 0.013059505671747039d, new GammaParticle(100119.0, 0.01238) }, { 0.017343023532080067d, new GammaParticle(101370.0, 0.01223) }, { 0.0042835178603330285d, new GammaParticle(102948.0, 0.01204) } } },

        };
    }
}
    