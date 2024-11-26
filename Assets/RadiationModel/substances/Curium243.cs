using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium243";
        public override double halfLife { get; } = 918306545.86063d;
        public override double atomicWeight { get; } = 243.06139d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9971d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium239()), new(1.0d, new AlphaParticle(7190702.09)), new(0.00014957d, new GammaParticle(7860.0, 0.15774)), new(0.0013d, new GammaParticle(44663.0, 0.02776)), new(0.001994d, new GammaParticle(49412.0, 0.02509)), new(0.0004986d, new GammaParticle(57273.0, 0.02165)), new(0.0008974d, new GammaParticle(57300.0, 0.02164)), new(0.00015d, new GammaParticle(61460.0, 0.02017)), new(0.002d, new GammaParticle(67841.0, 0.01828)), new(1.5954e-05d, new GammaParticle(88060.0, 0.01408)), new(7.976799999999999e-05d, new GammaParticle(101960.0, 0.01216)), new(0.0031d, new GammaParticle(106125.0, 0.01168)), new(0.00013561d, new GammaParticle(106470.0, 0.01164)), new(0.00012d, new GammaParticle(166390.0, 0.00745)), new(0.0329d, new GammaParticle(209753.0, 0.00591)), new(0.106d, new GammaParticle(228183.0, 0.00543)), new(0.0011d, new GammaParticle(254400.0, 0.00487)), new(0.0008d, new GammaParticle(272870.0, 0.00454)), new(0.14d, new GammaParticle(277599.0, 0.00447)), new(0.00728d, new GammaParticle(285460.0, 0.00434)), new(0.00017d, new GammaParticle(311700.0, 0.00398)), new(0.000179d, new GammaParticle(315880.0, 0.00393)), new(7.000000000000001e-05d, new GammaParticle(322300.0, 0.00385)), new(0.000239d, new GammaParticle(334310.0, 0.00371)), new(0.493323042792845d, new GammaParticle(17604.0, 0.07043)), new(0.12540655532785996d, new GammaParticle(99533.0, 0.01246)), new(0.19852232915602339d, new GammaParticle(103741.0, 0.01195)), new(0.07286596287944815d, new GammaParticle(117130.0, 0.01059)), new(0.09815045199861665d, new GammaParticle(118619.0, 0.01045)), new(0.025284489119168505d, new GammaParticle(120544.0, 0.01029)) } },
            { 0.0029d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium243()) } },
            { 5.3000000000000004e-11d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    