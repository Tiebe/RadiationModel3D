using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium239";
        public override double halfLife { get; } = 42840.0d;
        public override double atomicWeight { get; } = 239.05302d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9998999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium239()), new(0.000154d, new GammaParticle(7860.0, 0.15774)), new(0.0009d, new GammaParticle(44663.0, 0.02776)), new(0.0011d, new GammaParticle(49412.0, 0.02509)), new(0.0009d, new GammaParticle(57273.0, 0.02165)), new(0.0008d, new GammaParticle(57300.0, 0.02164)), new(2e-05d, new GammaParticle(61480.0, 0.02017)), new(0.0013d, new GammaParticle(67841.0, 0.01828)), new(8e-06d, new GammaParticle(88060.0, 0.01408)), new(8e-05d, new GammaParticle(101965.0, 0.01216)), new(0.00043d, new GammaParticle(106100.0, 0.01169)), new(7.000000000000001e-05d, new GammaParticle(106500.0, 0.01164)), new(0.001d, new GammaParticle(124416.0, 0.00997)), new(8.999999999999999e-05d, new GammaParticle(166390.0, 0.00745)), new(0.0108d, new GammaParticle(181715.0, 0.00682)), new(0.035d, new GammaParticle(209800.0, 0.00591)), new(0.033d, new GammaParticle(226383.0, 0.00548)), new(0.113d, new GammaParticle(228184.0, 0.00543)), new(0.00084d, new GammaParticle(254400.0, 0.00487)), new(0.00064d, new GammaParticle(272800.0, 0.00454)), new(0.15d, new GammaParticle(277604.0, 0.00447)), new(0.008d, new GammaParticle(285500.0, 0.00434)), new(0.00017d, new GammaParticle(311700.0, 0.00398)), new(3.2e-05d, new GammaParticle(315900.0, 0.00392)), new(2.6e-05d, new GammaParticle(322300.0, 0.00385)), new(4.2e-05d, new GammaParticle(334300.0, 0.00371)), new(1.7e-05d, new GammaParticle(430000.0, 0.00288)), new(8e-05d, new GammaParticle(436000.0, 0.00284)), new(1.2e-06d, new GammaParticle(448300.0, 0.00277)), new(0.00012d, new GammaParticle(454600.0, 0.00273)), new(1.5e-05d, new GammaParticle(497800.0, 0.00249)), new(0.00014000000000000001d, new GammaParticle(504000.0, 0.00246)), new(0.899129502666112d, new GammaParticle(17604.0, 0.07043)), new(0.35629375693392473d, new GammaParticle(99533.0, 0.01246)), new(0.5640236772739035d, new GammaParticle(103741.0, 0.01195)), new(0.2070201800779302d, new GammaParticle(117130.0, 0.01059)), new(0.27885618256497197d, new GammaParticle(118619.0, 0.01045)), new(0.07183600248704178d, new GammaParticle(120544.0, 0.01029)) } },
            { 0.0001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium235()), new(1.0d, new AlphaParticle(6944402.09)), new(5e-05d, new GammaParticle(48800.0, 0.02541)), new(1.60965e-05d, new GammaParticle(17136.0, 0.07235)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    