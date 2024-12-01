using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium75";
        public override double halfLife { get; } = 10348992.0d;
        public override double atomicWeight { get; } = 74.92252d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic75()), new(1.178e-05d, new GammaParticle(14890.0, 0.08327)), new(0.00025327d, new GammaParticle(24380.0, 0.05085)), new(0.01111443d, new GammaParticle(66051.8, 0.01877)), new(8.481600000000001e-05d, new GammaParticle(81150.0, 0.01528)), new(0.03448595d, new GammaParticle(96734.0, 0.01282)), new(0.1720469d, new GammaParticle(121115.5, 0.01024)), new(0.5854659999999999d, new GammaParticle(136000.1, 0.00912)), new(0.0149606d, new GammaParticle(198606.0, 0.00624)), new(8.835e-08d, new GammaParticle(249400.0, 0.00497)), new(0.589d, new GammaParticle(264657.6, 0.00468)), new(0.2502072d, new GammaParticle(279542.2, 0.00444)), new(0.01314648d, new GammaParticle(303923.6, 0.00408)), new(2.5327e-05d, new GammaParticle(373860.0, 0.00332)), new(0.1141482d, new GammaParticle(400657.2, 0.00309)), new(0.00012369d, new GammaParticle(419080.0, 0.00296)), new(3.6518e-06d, new GammaParticle(468600.0, 0.00265)), new(1.2958e-07d, new GammaParticle(542400.0, 0.00229)), new(9.423999999999999e-09d, new GammaParticle(557800.0, 0.00222)), new(0.00036164599999999997d, new GammaParticle(572400.0, 0.00217)), new(4.5058499999999996e-05d, new GammaParticle(617670.0, 0.00201)), new(1.3723699999999998e-06d, new GammaParticle(821600.0, 0.00151)), new(0.020499999999999997d, new GammaParticle(1320.0, 0.93927)), new(0.1653d, new GammaParticle(10509.0, 0.11798)), new(0.321d, new GammaParticle(10544.0, 0.11759)), new(0.0733d, new GammaParticle(11773.0, 0.10531)), new(0.0761d, new GammaParticle(11791.0, 0.10515)), new(0.0027700000000000003d, new GammaParticle(11861.0, 0.10453)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    