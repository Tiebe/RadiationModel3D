using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium159";
        public override double halfLife { get; } = 11.37d;
        public override double atomicWeight { get; } = 158.93322d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium159() }, { 1.0d, new BetaParticle(-1, 1917500.0) }, { 0.0115d, new GammaParticle(64760.0, 0.01915) }, { 0.044160000000000005d, new GammaParticle(75440.0, 0.01643) }, { 0.00782d, new GammaParticle(82580.0, 0.01501) }, { 0.00828d, new GammaParticle(96650.0, 0.01283) }, { 0.03634d, new GammaParticle(114420.0, 0.01084) }, { 0.00966d, new GammaParticle(143900.0, 0.00862) }, { 0.01564d, new GammaParticle(172090.0, 0.0072) }, { 0.0575d, new GammaParticle(179090.0, 0.00692) }, { 0.46d, new GammaParticle(189790.0, 0.00653) }, { 0.09752000000000001d, new GammaParticle(254430.0, 0.00487) }, { 0.0115d, new GammaParticle(333200.0, 0.00372) }, { 0.06072d, new GammaParticle(797200.0, 0.00156) }, { 0.18216000000000002d, new GammaParticle(861970.0, 0.00144) }, { 0.023d, new GammaParticle(879780.0, 0.00141) }, { 0.02622d, new GammaParticle(976650.0, 0.00127) }, { 0.0276d, new GammaParticle(1051700.0, 0.00118) }, { 0.05306644606185216d, new GammaParticle(6603.0, 0.18777) }, { 0.06539273739025167d, new GammaParticle(40901.0, 0.03031) }, { 0.11799483469911885d, new GammaParticle(41541.0, 0.02985) }, { 0.03717315650460214d, new GammaParticle(47146.0, 0.0263) }, { 0.04676383088278949d, new GammaParticle(47645.0, 0.02602) }, { 0.009590674378187352d, new GammaParticle(48248.0, 0.0257) } } },

        };
    }
}
    