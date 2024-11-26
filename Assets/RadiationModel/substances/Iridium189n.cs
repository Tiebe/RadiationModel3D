using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium189n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium189n";
        public override double halfLife { get; } = 0.0037d;
        public override double atomicWeight { get; } = 188.96123d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium189() }, { 0.205d, new GammaParticle(68100.0, 0.01821) }, { 0.09d, new GammaParticle(84500.0, 0.01467) }, { 0.01d, new GammaParticle(101000.0, 0.01228) }, { 0.045d, new GammaParticle(113800.0, 0.01089) }, { 0.0155d, new GammaParticle(115200.0, 0.01076) }, { 0.34d, new GammaParticle(120800.0, 0.01026) }, { 0.14d, new GammaParticle(140100.0, 0.00885) }, { 0.08d, new GammaParticle(149600.0, 0.00829) }, { 0.01d, new GammaParticle(153600.0, 0.00807) }, { 0.0017000000000000001d, new GammaParticle(172100.0, 0.0072) }, { 0.055d, new GammaParticle(186700.0, 0.00664) }, { 0.065d, new GammaParticle(208200.0, 0.00596) }, { 0.045d, new GammaParticle(209300.0, 0.00592) }, { 0.04d, new GammaParticle(217500.0, 0.0057) }, { 0.025d, new GammaParticle(224000.0, 0.00554) }, { 0.45d, new GammaParticle(247600.0, 0.00501) }, { 0.04d, new GammaParticle(252500.0, 0.00491) }, { 0.07d, new GammaParticle(292100.0, 0.00424) }, { 0.095d, new GammaParticle(300400.0, 0.00413) }, { 0.11d, new GammaParticle(340200.0, 0.00364) }, { 0.14d, new GammaParticle(364700.0, 0.0034) }, { 0.045d, new GammaParticle(378100.0, 0.00328) }, { 0.025d, new GammaParticle(429000.0, 0.00289) }, { 0.055d, new GammaParticle(430400.0, 0.00288) }, { 0.0315d, new GammaParticle(438300.0, 0.00283) }, { 0.175d, new GammaParticle(445300.0, 0.00278) }, { 0.1d, new GammaParticle(464400.0, 0.00267) }, { 0.4d, new GammaParticle(465700.0, 0.00266) }, { 0.06d, new GammaParticle(491900.0, 0.00252) }, { 0.03d, new GammaParticle(531400.0, 0.00233) }, { 0.48d, new GammaParticle(545700.0, 0.00227) }, { 0.22d, new GammaParticle(550300.0, 0.00225) }, { 0.06d, new GammaParticle(563500.0, 0.0022) }, { 0.04d, new GammaParticle(607400.0, 0.00204) }, { 0.1d, new GammaParticle(614000.0, 0.00202) }, { 0.19d, new GammaParticle(623600.0, 0.00199) }, { 0.0155d, new GammaParticle(676300.0, 0.00183) }, { 0.435d, new GammaParticle(701400.0, 0.00177) }, { 0.08d, new GammaParticle(725300.0, 0.00171) }, { 0.25315720300035d, new GammaParticle(10728.0, 0.11557) }, { 0.190952834150398d, new GammaParticle(63287.0, 0.01959) }, { 0.32770350806658316d, new GammaParticle(64896.0, 0.01911) }, { 0.10995676156119945d, new GammaParticle(73637.0, 0.01684) }, { 0.14107452508301888d, new GammaParticle(74510.0, 0.01664) }, { 0.031117763521819445d, new GammaParticle(75576.0, 0.01641) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    