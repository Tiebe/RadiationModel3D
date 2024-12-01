using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium189n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium189n";
        public override double halfLife { get; } = 0.0037d;
        public override double atomicWeight { get; } = 188.96123d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium189()), new(0.205d, new GammaParticle(68100.0, 0.01821)), new(0.09d, new GammaParticle(84500.0, 0.01467)), new(0.01d, new GammaParticle(101000.0, 0.01228)), new(0.045d, new GammaParticle(113800.0, 0.01089)), new(0.0155d, new GammaParticle(115200.0, 0.01076)), new(0.34d, new GammaParticle(120800.0, 0.01026)), new(0.14d, new GammaParticle(140100.0, 0.00885)), new(0.08d, new GammaParticle(149600.0, 0.00829)), new(0.01d, new GammaParticle(153600.0, 0.00807)), new(0.0017000000000000001d, new GammaParticle(172100.0, 0.0072)), new(0.055d, new GammaParticle(186700.0, 0.00664)), new(0.065d, new GammaParticle(208200.0, 0.00596)), new(0.045d, new GammaParticle(209300.0, 0.00592)), new(0.04d, new GammaParticle(217500.0, 0.0057)), new(0.025d, new GammaParticle(224000.0, 0.00554)), new(0.45d, new GammaParticle(247600.0, 0.00501)), new(0.04d, new GammaParticle(252500.0, 0.00491)), new(0.07d, new GammaParticle(292100.0, 0.00424)), new(0.095d, new GammaParticle(300400.0, 0.00413)), new(0.11d, new GammaParticle(340200.0, 0.00364)), new(0.14d, new GammaParticle(364700.0, 0.0034)), new(0.045d, new GammaParticle(378100.0, 0.00328)), new(0.025d, new GammaParticle(429000.0, 0.00289)), new(0.055d, new GammaParticle(430400.0, 0.00288)), new(0.0315d, new GammaParticle(438300.0, 0.00283)), new(0.175d, new GammaParticle(445300.0, 0.00278)), new(0.1d, new GammaParticle(464400.0, 0.00267)), new(0.4d, new GammaParticle(465700.0, 0.00266)), new(0.06d, new GammaParticle(491900.0, 0.00252)), new(0.03d, new GammaParticle(531400.0, 0.00233)), new(0.48d, new GammaParticle(545700.0, 0.00227)), new(0.22d, new GammaParticle(550300.0, 0.00225)), new(0.06d, new GammaParticle(563500.0, 0.0022)), new(0.04d, new GammaParticle(607400.0, 0.00204)), new(0.1d, new GammaParticle(614000.0, 0.00202)), new(0.19d, new GammaParticle(623600.0, 0.00199)), new(0.0155d, new GammaParticle(676300.0, 0.00183)), new(0.435d, new GammaParticle(701400.0, 0.00177)), new(0.08d, new GammaParticle(725300.0, 0.00171)), new(0.25315720300035d, new GammaParticle(10728.0, 0.11557)), new(0.190952834150398d, new GammaParticle(63287.0, 0.01959)), new(0.32770350806658316d, new GammaParticle(64896.0, 0.01911)), new(0.10995676156119945d, new GammaParticle(73637.0, 0.01684)), new(0.14107452508301888d, new GammaParticle(74510.0, 0.01664)), new(0.031117763521819445d, new GammaParticle(75576.0, 0.01641)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    