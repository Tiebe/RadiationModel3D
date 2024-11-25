using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin127m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin127m";
        public override double halfLife { get; } = 247.8d;
        public override double atomicWeight { get; } = 126.9104d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony127() }, { 1.0d, new BetaParticle(-1, 1616500.0) }, { 0.001261d, new GammaParticle(342300.0, 0.00362) }, { 0.001067d, new GammaParticle(354800.0, 0.00349) }, { 0.000485d, new GammaParticle(369100.0, 0.00336) }, { 0.0033950000000000004d, new GammaParticle(419900.0, 0.00295) }, { 0.97d, new GammaParticle(490600.0, 0.00253) }, { 0.009506d, new GammaParticle(695300.0, 0.00178) }, { 0.013191999999999999d, new GammaParticle(765200.0, 0.00162) }, { 0.002231d, new GammaParticle(1075200.0, 0.00115) }, { 0.014258999999999999d, new GammaParticle(1210200.0, 0.00102) }, { 0.005044d, new GammaParticle(1220510.0, 0.00102) }, { 0.013483d, new GammaParticle(1349200.0, 0.00092) }, { 0.007275d, new GammaParticle(1351600.0, 0.00092) }, { 0.000485d, new GammaParticle(1471200.0, 0.00084) }, { 0.000485d, new GammaParticle(1503500.0, 0.00082) }, { 0.014646999999999999d, new GammaParticle(1564300.0, 0.00079) }, { 0.0020369999999999997d, new GammaParticle(1659400.0, 0.00075) }, { 0.0008730000000000001d, new GammaParticle(1813100.0, 0.00068) }, { 0.004462d, new GammaParticle(1840300.0, 0.00067) } } },

        };
    }
}
    