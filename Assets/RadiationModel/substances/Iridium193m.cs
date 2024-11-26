using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium193m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium193m";
        public override double halfLife { get; } = 909792.0d;
        public override double atomicWeight { get; } = 192.96301d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium193() }, { 4.67e-05d, new GammaParticle(80220.0, 0.01546) }, { 0.21855314283d, new GammaParticle(10728.0, 0.11557) }, { 0.0013947385299700815d, new GammaParticle(63287.0, 0.01959) }, { 0.002393579080092812d, new GammaParticle(64896.0, 0.01911) }, { 0.0008031351441442768d, new GammaParticle(73637.0, 0.01684) }, { 0.0010304223899371071d, new GammaParticle(74510.0, 0.01664) }, { 0.00022728724579283032d, new GammaParticle(75576.0, 0.01641) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    