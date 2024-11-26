using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium192n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium192n";
        public override double halfLife { get; } = 7605219159.87667d;
        public override double atomicWeight { get; } = 191.96278d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium192() }, { 1.7500000000000002e-05d, new GammaParticle(12984.0, 0.09549) }, { 0.001d, new GammaParticle(155160.0, 0.00799) }, { 0.42658529561999997d, new GammaParticle(10728.0, 0.11557) }, { 0.0017801632927252331d, new GammaParticle(63287.0, 0.01959) }, { 0.0030550253865200497d, new GammaParticle(64896.0, 0.01911) }, { 0.0010250750746334505d, new GammaParticle(73637.0, 0.01684) }, { 0.001315171320754717d, new GammaParticle(74510.0, 0.01664) }, { 0.0002900962461212665d, new GammaParticle(75576.0, 0.01641) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    